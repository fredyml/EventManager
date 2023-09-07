using EventManager.Application.Interfaces;
using EventManager.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EventManager.Controllers
{
    /// <summary>
    /// Controlador API para gestionar eventos.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly IEventLogRepository _repository;

        /// <summary>
        /// Inicializa una nueva instancia de la clase EventsController.
        /// </summary>
        /// <param name="repository">El repositorio para interactuar con los eventos en la base de datos.</param>
        public EventsController(IEventLogRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Añade un nuevo evento a la base de datos.
        /// </summary>
        /// <param name="eventLog">El evento a añadir.</param>
        /// <returns>El evento que fue añadido.</returns>
        [HttpPost]
        public async Task<IActionResult> AddEvent(EventLog eventLog)
        {
            await _repository.AddAsync(eventLog);
            await _repository.SaveChangesAsync();
            return Ok(eventLog);
        }

        /// <summary>
        /// Obtiene eventos de la base de datos. Puede filtrarse por tipo de evento y/o rango de fechas.
        /// </summary>
        /// <param name="eventType">Tipo de evento por el que filtrar (opcional).</param>
        /// <param name="startDate">Fecha inicial del rango (opcional).</param>
        /// <param name="endDate">Fecha final del rango (opcional).</param>
        /// <returns>Una lista de eventos que coinciden con los criterios de búsqueda.</returns>
        [HttpGet]
        public async Task<IActionResult> GetEvents(int eventTypeId, DateTime? startDate, DateTime? endDate)
        {
            var query = _repository.GetEvents();

            if (eventTypeId > 0)
            {
                query = query.Where(e => e.EventTypeId == eventTypeId);
            }

            if (startDate.HasValue)
            {
                query = query.Where(e => e.Date >= startDate.Value);
            }

            if (endDate.HasValue)
            {
                query = query.Where(e => e.Date <= endDate.Value);
            }

            return Ok(await query.ToListAsync());
        }
    }
}

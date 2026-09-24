using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClinicaOdontologica.Modelos;

[Route("api/[controller]")]
[ApiController]
public class DetalleCitasController : ControllerBase
{
    private readonly ClinicaOodontologicaAPIContext _context;
    public DetalleCitasController(ClinicaOodontologicaAPIContext context)
    {
        _context = context;
    }

    // GET: api/DetalleCita
    [HttpGet]
    public async Task<ActionResult<IEnumerable<DetalleCita>>> GetDetalleCita()
    {
        return await _context.DetalleCita.ToListAsync();
    }

    // GET: api/DetalleCita/5
    [HttpGet("{iddetallecita}")]
    public async Task<ActionResult<DetalleCita>> GetDetalleCita(int iddetallecita)
    {
        var detallecita = await _context.DetalleCita.FindAsync(iddetallecita);

        if (detallecita == null)
        {
            return NotFound();
        }

        return detallecita;
    }

    // PUT: api/DetalleCita/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{iddetallecita}")]
    public async Task<IActionResult> PutDetalleCita(int? iddetallecita, DetalleCita detallecita)
    {
        if (iddetallecita != detallecita.idDetalleCita)
        {
            return BadRequest();
        }

        _context.Entry(detallecita).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!DetalleCitaExists(iddetallecita))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // POST: api/DetalleCita
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<DetalleCita>> PostDetalleCita(DetalleCita detallecita)
    {
        _context.DetalleCita.Add(detallecita);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetDetalleCita", new { iddetallecita = detallecita.idDetalleCita }, detallecita);
    }

    // DELETE: api/DetalleCita/5
    [HttpDelete("{iddetallecita}")]
    public async Task<IActionResult> DeleteDetalleCita(int? iddetallecita)
    {
        var detallecita = await _context.DetalleCita.FindAsync(iddetallecita);
        if (detallecita == null)
        {
            return NotFound();
        }

        _context.DetalleCita.Remove(detallecita);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool DetalleCitaExists(int? iddetallecita)
    {
        return _context.DetalleCita.Any(e => e.idDetalleCita == iddetallecita);
    }
}

using Euvic.WebAPI.HttpResponses.Controllers.Requests;
using Euvic.WebAPI.HttpResponses.Models;
using Microsoft.AspNetCore.Mvc;

namespace Euvic.WebAPI.HttpResponses.Controllers
{
    [Route("api/trainings")]
    [ApiController]
    public class TrainingsController : ControllerBase
    {
        //
        // Większość odpowiedzi http są zaimplementowane jako gotowe do użycia metody. Poniżej jest lista metod które są najczęściej wykorzystywane
        //
        // Ok() 200
        // NoContent() 204
        // BadRequest() 400
        // Unauthorized() 401
        // Forbid() 403
        // NotFound() 404
        // ----------------------------------------------------------------------------------------------------------------

        // ten endpoint jest gotowy
        // endpoint powinien zwrócic obiekt TrainingsList więc została zastosowana tutaj metoda Ok()
        [HttpGet("")]
        public IActionResult GetTrainings() => Ok(new TrainingsList());

        // endpointy poniżej są do zrobienia
        // ----------------------------------------------------------------------------------------------------------------

        // endpoint ma zwrócic kolekcję obiektów "Models.Attendee"
        [HttpGet("{id}/attendees")]
        public IActionResult GetTrainingAttendees() => [?];

        // endpoint powinien zwrócić że udało się stworzyć trening i ten trening zostaje zwrócony w odpowiedzi (obiekt Models.Training)
        [HttpPost("")]
        public IActionResult CreateTraining() =>  [?];

        // endpoint powinien zwrócić że użytkownik ma nieważny token służący do uwierzytelnienia
        [HttpPost("")]
        public IActionResult CreateTrainingBadToken() =>  [?];

        // endpoint powinien zwrócić że użytkownik ma ważny token lecz nie ma uprawnień w aplikacji aby wykonać ten request
        [HttpDelete("{id}")]
        public IActionResult DeleteTraining([FromRoute] int id) => [?];

        [HttpDelete("{id}/attendee")]
        public IActionResult DeleteAttendee([FromRoute] int id) => [?];

        // endpoint ma zwrócic odpowiedź że update się udał lecz nic nie zostaje zwrócone
        [HttpPut("{id}")]
        public IActionResult UpdateTraining([FromRoute] int id, [FromBody] UpdateTrainingRequest request) =>  [?];

        // endpoint ma zwrócic odpowiedź że nie udało się zmienić "duration"
        [Route("{id}/duration")]
        public IActionResult ChangeTrainingDuration([FromRoute] int id, [FromBody] int durationInMinutes) =>  [?];
    }
}

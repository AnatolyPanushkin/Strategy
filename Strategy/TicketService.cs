using Strategy.Models;

namespace Strategy;

public class TicketService
{
    private readonly ITiketable _service;

    private List<Place> _enablePlaces { get; set; }
    
    public TicketService(ITiketable ticketService)
    {
        _service = ticketService;
    }

    public async void GetPlaces()
    {
        _enablePlaces = await _service.GetEnablePlaces();
    }

    public void PickPlaces()
    {
        _service.PickPlaces(_enablePlaces);
    }

    public async Task<Ticket> BuyTicket()
    {
        return await _service.BuyTickets(_enablePlaces);
    }
    
}
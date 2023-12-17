using Strategy.Models;

namespace Strategy;

public class OperaTicket:ITiketable
{
    public Task<List<Place>> GetEnablePlaces()
    {
        throw new NotImplementedException();
    }

    public Task<List<Place>> PickPlaces(List<Place> places)
    {
        throw new NotImplementedException();
    }

    public Task<Ticket> BuyTickets(List<Place> places)
    {
        throw new NotImplementedException();
    }
}
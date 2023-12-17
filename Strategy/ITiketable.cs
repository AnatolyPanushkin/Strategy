using Strategy.Models;

namespace Strategy;

public interface ITiketable
{
    public Task<List<Place>> GetEnablePlaces();

    public Task<List<Place>> PickPlaces(List<Place> places);

    public Task<Ticket> BuyTickets(List<Place> places);
}
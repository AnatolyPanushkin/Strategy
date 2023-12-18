using Strategy.Models;

namespace Strategy;

public class OperaTicket:ITiketable
{
    public async Task<List<Place>> GetEnablePlaces()
    {
        Console.WriteLine("Обращение к сервису оперы для получения свободных мест");

        var places = new List<Place>(){new Place
            {
                Type = "standart",
                Number = 2,
                Row = 1
            },
            new()
            {
                Type = "standart",
                Number = 2,
                Row = 1
            },
            new()
            {
                Type = "standart",
                Number = 1,
                Row = 1
            }
        };
        
        return places;
    }

    public async Task<List<Place>> PickPlaces(List<Place> places)
    {
        foreach (var place in places)
        {
            Console.WriteLine($"Забранировано место {place.Type}, {place.Row}, {place.Number}");
        }

        return places;
    }

    public async Task<Ticket> BuyTickets(List<Place> places)
    {
        foreach (var place in places)
        {
            Console.WriteLine($"Куплены места {place.Type}, {place.Row}, {place.Number}");
        }

        var ticket = new Ticket
        {
            Description = "опера",
            Places = places,
            Address = "address",
            Time = "18:00:00"
        };
        return ticket;
    }
}
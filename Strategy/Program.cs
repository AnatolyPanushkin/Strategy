// See https://aka.ms/new-console-template for more information

using Strategy;

var cinema = new CinemaTicket();

TicketService ticketService = new TicketService(cinema);

ticketService.GetPlaces();

ticketService.PickPlaces();

var ticket = await ticketService.BuyTicket();
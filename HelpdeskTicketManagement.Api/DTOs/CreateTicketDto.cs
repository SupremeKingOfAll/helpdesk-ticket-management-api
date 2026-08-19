using HelpdeskTicketManagement.Api.Enums;

namespace HelpdeskTicketManagement.Api.DTOs;


public class CreateTicketDto
{
    public required string Title { get; set; }
    public required string Description { get; set; }    
    public TicketPriority Priority { get; set; } = TicketPriority.Low;

    public required string CreatedBy { get; set; }

}

//This file controls what data someone is allowed to send when creating a ticket.
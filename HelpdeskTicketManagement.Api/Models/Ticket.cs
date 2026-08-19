using HelpdeskTicketManagement.Api.Enums;

namespace HelpdeskTicketManagement.Api.Models;


class Ticket
{
    public int TicketId { get; set; } //Unique ID for a ticket.
    public string Title { get; set; } //Title required. Example: "Cannot log in".
    public string Description { get; set; } //Longer explanation of the issue.

    public TicketStatus Status { get; set; } = TicketStatus.Open; //Every new ticket starts as open on default.

    public TicketPriority Priority { get; set; } = TicketPriority.Low; //Every ticket starts with low priority unless it's changed.

    public required string CreatedBy { get; set; } //Person who created the ticket.

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow; //Automatically stores when the ticket was created.

    public DateTime? UpdatedAt { get; set; } //Automatically stores when the ticket was updated.
}

/*
 
Question mark means it can be null or empty.

=

TicketId: 1
Title: Cannot log in
Description: User cannot access their account
Status: Open
Priority: High
CreatedBy: Khalid
CreatedAt: 05/08/2026
UpdatedAt: null

*/
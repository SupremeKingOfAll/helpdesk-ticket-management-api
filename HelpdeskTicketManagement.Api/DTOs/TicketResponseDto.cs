using HelpdeskTicketManagement.Api.Enums;

namespace HelpdeskTicketManagement.Api.Enums;


class TicketResponseDtos
{

    public int TicketId { get; set; }

    public required string Title { get; set; }

    public required string Description { get; set; }

    public TicketStatus Status { get; set; }

    public TicketPriority Priority { get; set; }

    public required string CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UodatedAt { get; set; }
}

/*
 *
 * This controls what the API sends back.
 * 
 * When someone asks for a ticket, we might return
 * 
 */
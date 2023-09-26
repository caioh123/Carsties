﻿using Microsoft.AspNetCore.Http.Features;

namespace AuctionService.Entities;

public class Auction
{
    public Guid Id {get;set;}

    public string Seller { get; set; }
    public string Winner { get; set; }
    public int? SoldAmount { get; set; }
    public int? CurrentHighBid { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime AuctionEnd { get; set; } = DateTime.UtcNow;
    public Status Status { get; set; }

    public int ReservePrice {get;set;} = 0;
    public Item Item {get;set;}
}

﻿namespace Application.Features.Rentals.Dtos;

public class DeletedRentalDto
{
    public int Id { get; set; }
    public string CarModelBrandName { get; set; }
    public string CarModelName { get; set; }
    public string CustomerFullName { get; set; }
    public DateTime RentStartDate { get; set; }
    public DateTime RentEndDate { get; set; }
}
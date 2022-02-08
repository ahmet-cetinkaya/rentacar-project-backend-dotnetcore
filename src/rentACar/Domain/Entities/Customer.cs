﻿using Core.Persistence.Repositories;

namespace Domain.Entities;

public class Customer : Entity
{
    public string Email { get; set; }

    public virtual CorporateCustomer CorporateCustomer { get; set; }
    public virtual FindeksCreditRate FindeksCreditRate { get; set; }
    public virtual IndividualCustomer IndividualCustomer { get; set; }
    public virtual ICollection<Invoice> Invoices { get; set; }
    public virtual ICollection<Rental> Rentals { get; set; }


    public Customer()
    {
        Invoices = new List<Invoice>();
        Rentals = new List<Rental>();
    }

    public Customer(int id, string email) : base(id)
    {
        Email = email;
    }
}
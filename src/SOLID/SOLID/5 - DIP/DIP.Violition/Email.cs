﻿namespace SOLID.DIP.DIP.Violition;
public class Email
{
    public string Address { get; set; }

    public bool Validate()
    {
        return Address.Contains("@");
    }
}

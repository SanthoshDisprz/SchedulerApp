﻿using System;
using System.ComponentModel.DataAnnotations;
namespace Appointments
{
    public class Appointment
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string? AppointmentTitle { get; set; }
        [Required]
        public string? AppointmentDate { get; set; }
        [Required]
        public DateTime? AppointmentStartDateTime { get; set; }
        [Required]
        public DateTime? AppointmentEndDateTime { get; set; }
        public string? AppointmentDescription { get; set; }
    }
}

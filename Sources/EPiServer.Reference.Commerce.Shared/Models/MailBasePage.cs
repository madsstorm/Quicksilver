﻿using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace EPiServer.Reference.Commerce.Shared.Models
{
    public abstract class MailBasePage : PageData
    {
        [CultureSpecific]
        [Display(
            Name = "Mail Title",
            Description = "Mail Title",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string MailTitle { get; set; }
    }
}
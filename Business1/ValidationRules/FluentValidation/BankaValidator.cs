using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business1.ValidationRules.FluentValidation
{
    public class BankaValidator:AbstractValidator<Banka>
    {
        public BankaValidator()
        {
            RuleFor(b => b.BankaAdi).NotEmpty();
            RuleFor(b => b.BankaAdi).MinimumLength(2);
            RuleFor(b => b.SubeAdi).NotEmpty();
        }
    }
}

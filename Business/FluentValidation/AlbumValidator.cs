using Business.Constants;
using Entities.DBClasses;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.FluentValidation
{
    public class AlbumValidator : AbstractValidator<Album>
    {
        public AlbumValidator()
        {
            RuleFor(p => p.ArtistName).NotEmpty();
            RuleFor(p => p.Title).NotEmpty();
            RuleFor(p => p.Stock).GreaterThan(0).WithMessage(ConstantMessages.AlbumStockWarning);
            RuleFor(p => p.Year).LessThan(0).WithMessage(ConstantMessages.AlbumYearWarning);
        }
    }
}

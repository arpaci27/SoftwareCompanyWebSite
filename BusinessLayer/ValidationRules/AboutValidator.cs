using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator: AbstractValidator<About>
    {
        public AboutValidator()
        {
                RuleFor(x=>x.Description).NotEmpty().WithMessage("Açıklama kısmını boş geçemezsiniz...!");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen görsel seçiniz...!");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Açıklama metni en az 50 karakter uzunluğunda olmalıdır...!");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Açıklama metni en fazla 1500 karakter uzunluğunda olabilir...!");
        }
    }
}

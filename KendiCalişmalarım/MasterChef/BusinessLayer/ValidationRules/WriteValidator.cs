using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriteValidator:AbstractValidator<WriterChef>
    {
      public WriteValidator()
        {
            RuleFor(x => x.WriterChefName).NotEmpty().WithMessage("İsim Ve Soyisim bos geçilemez.Lütfen kontrol ediniz..");
            RuleFor(x => x.WriterChefMail).NotEmpty().WithMessage("E-mail alan ıbos gecilemez.Lütfen kontrol ediniz.");
            RuleFor(x => x.WriterChefPassword).NotEmpty().WithMessage("Sifre alanı bos gecilemez.Lütfen kontrol ediniz.");
            RuleFor(x => x.WriterChefName).MinimumLength(2).WithMessage("isim alanı en az 2 karakterli olmalıdır");
            RuleFor(x => x.WriterChefName).MaximumLength(50).WithMessage("isim alanı en fazla 50 karakterli olmalıdır");
            RuleFor(x => x.WriterChefPassword).MinimumLength(3).WithMessage("Sifre 3 tane rakamdan fazla olmalıdır.");
        }
 
    }
}

using EntityLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public  class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x=>x.WriterName).NotEmpty().WithMessage("İsim Ve Soyisim bos geçilemez.Lütfen kontrol ediniz..");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("E-mail alan ıbos gecilemez.Lütfen kontrol ediniz.");
            RuleFor(x=>x.WriterPassword).NotEmpty().WithMessage("Sifre alanı bos gecilemez.Lütfen kontrol ediniz.");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("isim alanı en az 2 karakterli olmalıdır"); 
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("isim alanı en fazla 50 karakterli olmalıdır");
            RuleFor(x => x.WriterPassword).MinimumLength(3).WithMessage("Sifre 3 tane rakamdan fazla olmalıdır.");
            //RuleFor(x => x.WriterAbout).NotEmpty().MinimumLength(8).WithMessage("K");

        }


    }
}

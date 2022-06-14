using EntityLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {

            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığı boş gecilemez");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriği boş gecilemez");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog gorseli boş gecilemez");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Blog içeriği 150 karekterden fazla olmamalıdır");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Blog içeriği 5 karekterden fazla olmalıdır");

        }


    }
}

using FluentValidation;
using TaskProCore.Entities;

namespace TaskProCore.Models.Validations;

public class CommentValidation : AbstractValidator<Comment>
{
    public CommentValidation()
    {
        RuleFor(c => c.Content)
            .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
            .Length(2, 500).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
    }
}
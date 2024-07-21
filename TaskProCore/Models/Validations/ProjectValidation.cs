using FluentValidation;
using TaskProCore.Models;

namespace TaskProCore.Entities.Validations;

public class ProjectValidation : AbstractValidator<Project>
{
    public ProjectValidation()
    {
        RuleFor(p => p.Name)
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(100).WithMessage("Name must not exceed 100 characters.");
        
        RuleFor(p => p.Description)
            .MaximumLength(1000).WithMessage("Description must not exceed 1000 characters.");
        
        RuleFor(p => p.Status)
            .IsInEnum().WithMessage("Invalid status.");
    }
}
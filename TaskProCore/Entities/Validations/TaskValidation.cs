using FluentValidation;

namespace TaskProCore.Entities.Validations;

public class TaskValidation : AbstractValidator<Task>
{
    public TaskValidation()
    {
        RuleFor(t => t.Name)
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(100).WithMessage("Name must not exceed 100 characters.");
        
        RuleFor(t => t.Description)
            .MaximumLength(1000).WithMessage("Description must not exceed 1000 characters.");
        
        RuleFor(t => t.Status)
            .IsInEnum().WithMessage("Invalid status.");
        
        RuleFor(t => t.Priority)
            .IsInEnum().WithMessage("Invalid priority.");
    }
}
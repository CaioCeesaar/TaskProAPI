using FluentValidation;
using FluentValidation.Results;
using TaskProCore.Interfaces;
using TaskProCore.Models;
using TaskProCore.Models.Notifications;

namespace TaskProCore.Services;

public abstract class BaseService(INotificador notificador)
{
    private void Notify(ValidationResult validationResult)
    {
        foreach (var item in validationResult.Errors)
        {
            Notify(item.ErrorMessage);
        }
    }
    
    protected void Notify (string mensagem)
    {
        notificador.Handle(new Notification(mensagem));
    }
    
    
    protected bool ExecutarValidacao<TV, TE>(TV validacao, TE entidade) 
        where TV : AbstractValidator<TE> 
        where TE : Entity
    {
        var validator = validacao.Validate(entidade);
        
        if (validator.IsValid)
            return true;

        // TODO implementar notificação de erros pra usar com o fluentValidation
        
        return false;
    }
}
using FluentValidation;
using TaskProCore.Entities;

namespace TaskProCore.Services;

public abstract class BaseService
{
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
using MediatR;

namespace GebruikersbeheerZvz.Handlers.Commands
{
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}

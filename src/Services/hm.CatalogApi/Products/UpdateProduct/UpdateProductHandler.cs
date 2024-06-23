
namespace hm.CatalogApi.Products.UpdateProduct;

public record UpdateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price):ICommand<UpdateProductResult>;

public record UpdateProductResult(bool IsSuccess);

internal class UpdateProductCommandHandler : ICommandHandler<UpdateProductCommand, UpdateProductResult>
{
    public Task<UpdateProductResult> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

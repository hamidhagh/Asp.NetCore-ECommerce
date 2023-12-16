using _0_Framework.Application;
using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Domain.ProductCategoryAgg;

namespace ShopManagement.Application
{
    public class ProductCategoryApplication : IProductCategoryApplication
    {
        private readonly IProductCategoryRepository _productCategoryRepostory;

        public ProductCategoryApplication(IProductCategoryRepository productCategoryRepostory)
        {
            _productCategoryRepostory = productCategoryRepostory;
        }

        public OperationResult Create(CreateProductCategory command)
        {
            var operation = new OperationResult();
            if (_productCategoryRepostory.Exists(x => x.Name == command.Name))
                return operation.Failed("رکورد تکراری است");

            var slug = command.Slug.Slugify();

            var productCategory = new ProductCategory(command.Name, command.Description,
            command.Picture, command.PictureAlt, command.PictureTitle, command.Keywords,
            command.MetaDescription, slug);

            _productCategoryRepostory.Create(productCategory);
            _productCategoryRepostory.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Edit(EditProductCategory command)
        {
            var operation = new OperationResult();
            var productCategory = _productCategoryRepostory.Get(command.Id);

            if (productCategory == null)
                return operation.Failed("رکورد یافت نشد");
            if (_productCategoryRepostory.Exists(x => x.Name == command.Name && x.Id != command.Id))
                return operation.Failed("رکورد تکراری است");

            var slug = command.Slug.Slugify();
            productCategory.Edit(command.Name, command.Description, command.Picture,
            command.PictureAlt, command.PictureTitle, command.Keywords,
            command.MetaDescription, slug);

            _productCategoryRepostory.SaveChanges();
            return operation.Succedded();
        }

        public EditProductCategory GetDetails(long id)
        {
            return _productCategoryRepostory.GetDetails(id);
        }

        public List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel)
        {
            throw new NotImplementedException();
        }
    }
}

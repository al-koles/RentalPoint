select 
    [Set].set_id,
    ModelType.ModelTypeName, 
    Producer.ProducerName, 
    Brand.BrandName, 
    Model.ModelName,
    Detail.[Price(UAH)],
    Detail.Amount,
    Detail.IsReturnable
    from [Set]
        join Product on Product.product_id = [Set].product_id
        join Detail on Detail.detail_id = [Set].detail_id
        join Model on Detail.model_id = Model.model_id
        join Producer on Detail.producer_id = Producer.producer_id
        join Brand on Model.brand_id = Brand.brand_id
        join ModelType on Model.modelType_id = ModelType.modelType_id
    where 
        Detail.Amount != 0 and
        Product.product_id = (
            select Product.product_id
                from Product 
                    join Good on Good.product_id = Product.product_id
                    join Rent on Rent.copy_id = Good.good_id
                where Rent.rent_id = @rent_id
        );
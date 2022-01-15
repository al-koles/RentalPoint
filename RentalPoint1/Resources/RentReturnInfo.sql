select 
    Rent.rent_id,
    ModelType.ModelTypeName, 
    Producer.ProducerName, 
    Brand.BrandName, 
    Model.ModelName,
    Rent.[To(date)],
    Rent.[Deposit],
    Rent.ReturnCondition,
    Rent.Penalty
    from Rent
        join Good on Rent.copy_id = Good.good_id
        join Product on Good.product_id = Product.product_id
        join Model on Product.model_id = Model.model_id
        join Producer on Product.producer_id = Producer.producer_id
        join Brand on Model.brand_id = Brand.brand_id
        join ModelType on Model.modelType_id = ModelType.modelType_id
    where Rent.rent_id = @rent_id;
select 
    ModelType.ModelTypeName,
    Producer.ProducerName, 
    Brand.BrandName,
    Model.ModelName
    from Product
        join Model on Model.model_id = Product.model_id
        join Producer on Producer.producer_id = Product.producer_id
        join Brand on Brand.brand_id = Model.brand_id
        join ModelType on ModelType.modelType_id = Model.modelType_id
    where Product.product_id = @product_id;

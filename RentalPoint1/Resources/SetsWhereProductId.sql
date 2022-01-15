select 
    [Set].set_id,
    ModelType.ModelTypeName,
    Producer.ProducerName, 
    Brand.BrandName,
    Model.ModelName
    from [Set]
        join Product on Product.product_id = [Set].product_id
        join Detail on Detail.detail_id = [Set].detail_id
        join Model on Model.model_id = Detail.model_id
        join Producer on Producer.producer_id = Detail.producer_id
        join Brand on Brand.brand_id = Model.brand_id
        join ModelType on ModelType.modelType_id = Model.modelType_id
    where Product.product_id = @product_id;
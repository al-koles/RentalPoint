select 
    Detail.detail_id, 
    ModelType.ModelTypeName, 
    Producer.ProducerName, 
    Brand.BrandName, 
    Model.ModelName, 
    Detail.[Price(UAH)], 
    Detail.Amount, 
    Detail.IsReturnable
    from Detail
        join Model on Model.model_id = Detail.model_id
        join Producer on Producer.producer_id = Detail.producer_id
        join Brand on Brand.brand_id = Model.brand_id
        join ModelType on ModelType.modelType_id = Model.modelType_id

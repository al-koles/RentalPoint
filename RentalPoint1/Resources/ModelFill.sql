select
    Model.model_id, 
    ModelType.ModelTypeName,
    Brand.BrandName, 
    Model.ModelName
    from Model
        join Brand on Brand.brand_id = Model.brand_id
        join ModelType on ModelType.modelType_id = Model.modelType_id

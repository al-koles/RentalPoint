select
    Attachment.attachment_id,
    ModelType.ModelTypeName, 
    Producer.ProducerName, 
    Brand.BrandName, 
    Model.ModelName,
    Attachment.Amount,
    Attachment.ReturnAmount,
    Attachment.ReturnPrice
    from Rent
        join Attachment on Attachment.rent_id = Rent.rent_id
        join [Set] on [Set].set_id = Attachment.set_id
        join Detail on Detail.detail_id = [Set].detail_id
        join Product on Product.product_id = [Set].product_id
        join Producer on Producer.producer_id = Detail.producer_id
        join Model on Model.model_id = Detail.model_id
        join Brand on Brand.brand_id = Model.brand_id
        join ModelType on ModelType.modelType_id = Model.modelType_id
    where 
        Rent.rent_id = @rent_id and
        Detail.IsReturnable = 1;
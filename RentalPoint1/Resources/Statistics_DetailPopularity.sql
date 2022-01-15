select
    count(Attachment.attachment_id) as [AttachmentAmount],
    Detail.detail_id,
    ModelType.ModelTypeName, 
    Producer.ProducerName, 
    Brand.BrandName, 
    Model.ModelName
    from Attachment
        right join [Set] on [Set].set_id = Attachment.set_id
        right join Detail on Detail.detail_id = [Set].detail_id
        join Product on Product.product_id = [Set].product_id
        join Producer on Producer.producer_id = Detail.producer_id
        join Model on Model.model_id = Detail.model_id
        join Brand on Brand.brand_id = Model.brand_id
        join ModelType on ModelType.modelType_id = Model.modelType_id
    group by
        Detail.detail_id,
        ModelType.ModelTypeName, 
        Producer.ProducerName, 
        Brand.BrandName, 
        Model.ModelName
    order by [AttachmentAmount] desc, Detail.detail_id asc;
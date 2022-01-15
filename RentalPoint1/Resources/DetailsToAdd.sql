select Detail.detail_id, Attachment.ReturnAmount
    from Attachment 
        join [Set] on [Set].set_id = Attachment.set_id
        join Detail on Detail.detail_id = [Set].detail_id
    where Attachment.rent_id = @rent_id; 

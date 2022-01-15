select Detail.[Price(UAH)]
    from Detail 
        join [Set] on [Set].detail_id = Detail.detail_id
        join Attachment on Attachment.set_id = [Set].set_id
    where Attachment.attachment_id = @attachment_id;
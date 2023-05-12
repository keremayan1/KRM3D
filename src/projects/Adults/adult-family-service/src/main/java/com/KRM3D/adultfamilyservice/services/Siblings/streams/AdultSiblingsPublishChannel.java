package com.KRM3D.adultfamilyservice.services.Siblings.streams;

import org.springframework.cloud.stream.annotation.Output;
import org.springframework.messaging.MessageChannel;

public interface AdultSiblingsPublishChannel {
    String CREATE_OUTPUT_CHANNEL = "CreateAdultFamilySiblings";
    @Output(CREATE_OUTPUT_CHANNEL)
    MessageChannel createOutputChannel();

    String UPDATE_OUTPUT_CHANNEL = "UpdateAdultFamilySiblings";
    @Output(UPDATE_OUTPUT_CHANNEL)
    MessageChannel updateOutputChannel();

    String DELETE_OUTPUT_CHANNEL = "DeleteAdultFamilySiblings";
    @Output(DELETE_OUTPUT_CHANNEL)
    MessageChannel deleteOutputChannel();
}

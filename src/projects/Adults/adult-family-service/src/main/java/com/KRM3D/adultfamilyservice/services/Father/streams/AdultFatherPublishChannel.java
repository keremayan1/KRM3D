package com.KRM3D.adultfamilyservice.services.Father.streams;

import org.springframework.cloud.stream.annotation.Output;
import org.springframework.messaging.MessageChannel;

public interface AdultFatherPublishChannel {
    String CREATE_OUTPUT_CHANNEL = "CreateAdultFamilyFather";
    @Output(CREATE_OUTPUT_CHANNEL)
    MessageChannel createOutputChannel();

    String UPDATE_OUTPUT_CHANNEL = "UpdateAdultFamilyFather";
    @Output(UPDATE_OUTPUT_CHANNEL)
    MessageChannel updateOutputChannel();

    String DELETE_OUTPUT_CHANNEL = "DeleteAdultFamilyFather";
    @Output(DELETE_OUTPUT_CHANNEL)
    MessageChannel deleteOutputChannel();
}

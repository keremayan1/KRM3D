package com.KRM3D.adultquestionanswerservice.services.streams;

import org.springframework.cloud.stream.annotation.Output;
import org.springframework.messaging.MessageChannel;

public interface AdultQuestionAnswerPublishChannel {
    String CREATE_OUTPUT_CHANNEL = "CreateAdultQuestionAnswer";
    @Output(CREATE_OUTPUT_CHANNEL)
    MessageChannel createOutputChannel();

    String UPDATE_OUTPUT_CHANNEL = "UpdateAdultQuestionAnswer";
    @Output(UPDATE_OUTPUT_CHANNEL)
    MessageChannel updateOutputChannel();

    String DELETE_OUTPUT_CHANNEL = "DeleteAdultQuestionAnswer";
    @Output(DELETE_OUTPUT_CHANNEL)
    MessageChannel deleteOutputChannel();
}

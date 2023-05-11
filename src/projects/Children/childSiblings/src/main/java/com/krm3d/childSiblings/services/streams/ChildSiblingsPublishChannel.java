package com.krm3d.childSiblings.services.streams;

import org.springframework.cloud.stream.annotation.Output;
import org.springframework.messaging.MessageChannel;

public interface ChildSiblingsPublishChannel {
    String CREATE_OUTPUT_CHANNEL = "CreateChildSiblings";
    @Output(CREATE_OUTPUT_CHANNEL)
    MessageChannel createOutputChannel();

    String UPDATE_OUTPUT_CHANNEL = "UpdateChildSiblings";
    @Output(UPDATE_OUTPUT_CHANNEL)
    MessageChannel updateOutputChannel();

    String DELETE_OUTPUT_CHANNEL = "DeleteChildSiblings";
    @Output(DELETE_OUTPUT_CHANNEL)
    MessageChannel deleteOutputChannel();
}

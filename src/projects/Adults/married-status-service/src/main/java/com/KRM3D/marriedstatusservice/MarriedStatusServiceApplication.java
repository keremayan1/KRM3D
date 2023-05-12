package com.KRM3D.marriedstatusservice;

import org.modelmapper.ModelMapper;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.Bean;

@SpringBootApplication
public class MarriedStatusServiceApplication {

	public static void main(String[] args) {
		SpringApplication.run(MarriedStatusServiceApplication.class, args);
	}
	@Bean
	public ModelMapper modelMapper(){
		return  new ModelMapper();
	}
}

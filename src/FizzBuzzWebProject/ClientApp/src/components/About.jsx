﻿import React, { Component } from "react";

export class About extends Component {
    render() {
        return (
            <div style={{ padding: 60 }}>
                <p>
                    FizzBuzz test is a program that prints the numbers from 1 to 100. But
                    for multiples of three print “Fizz” instead of the number and for the
                    multiples of five print “Buzz”. For numbers which are multiples of
                    both three and five print “FizzBuzz
                </p>
            </div>
        );
    }
}

export default About;

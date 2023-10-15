import React from "react";
import { Button, Container, Menu, Segment } from "semantic-ui-react";

export default function NavBar(){
    return(
        <Segment>
            <Menu inverted fixed='top'>
                <Container>
                    <Menu.Item header>
                        <img src="/assets/logo.png" alt="logo" style={{marginRight: '10px'}}/>
                        CC Journal
                    </Menu.Item>
                    <Menu.Item name="Entries"/>
                    <Menu.Item>
                        <Button positive content = 'My Journal'/>
                    </Menu.Item>
                </Container>
            </Menu>
        </Segment>
    )
}
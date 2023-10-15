import React from "react";
import { Container, Divider, Grid, Item, Segment } from "semantic-ui-react";

export default function WeekView() {
  const daysOfWeek = ['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday'];

  return (
    <Grid centered>
        <Grid.Column width = '10'>
            <Segment.Group horizontal>
                    {daysOfWeek.map((day, index) => (
                        <Segment key={index}  textAlign="center">
                            <Item>
                                <Item.Content>
                                    <Item.Header as='a'>{day}</Item.Header >
                                    <Item.Meta>1100</Item.Meta>
                                </Item.Content>                         
                            </Item>
                        </Segment>                
                    ))}
            </Segment.Group>
        </Grid.Column>
    </Grid>
  );
}

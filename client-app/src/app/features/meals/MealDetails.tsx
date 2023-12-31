import { Fragment } from "react";
import { Button, Grid, Placeholder, Segment } from "semantic-ui-react";

export default function MealDetails() {
    return (
        <Grid centered>
            <Grid.Column width='10'>
                <Fragment>
                    <Placeholder fluid style={{ marginTop: 25 }}>
                        <Segment.Group>
                            <Segment style={{ minHeight: 110 }}>
                                <Placeholder>
                                    <Placeholder.Header image>
                                        <Placeholder.Line />
                                        <Placeholder.Line />
                                    </Placeholder.Header>
                                    <Placeholder.Paragraph>
                                        <Placeholder.Line />
                                    </Placeholder.Paragraph>
                                </Placeholder>
                            </Segment>
                            <Segment>
                                <Placeholder>
                                    <Placeholder.Line />
                                    <Placeholder.Line />
                                </Placeholder>
                            </Segment>
                            <Segment secondary style={{ minHeight: 70 }} />
                            <Segment clearing>
                                <Button disabled color='blue' floated='right' content='View' />
                            </Segment>
                        </Segment.Group>
                    </Placeholder>
                </Fragment>
            </Grid.Column>
        </Grid>
    )
}
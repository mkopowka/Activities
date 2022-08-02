import { toast } from "react-toastify";
import { Button, Header, Icon, Segment } from "semantic-ui-react";
import agent from "../../app/api/agent";
import useQuery from "../../app/common/util/hooks";

export default function RegisterSuccess() {
    const email = useQuery().get('email') as string;

    function handleConfirmEmailResend() {
        agent.Account.resentEmailConfirm(email).then(() => {
            toast.success('Verification email resend- please check ur email');
        }).catch(error => console.log(error));
    }

    return (
        <Segment placeholder textAlign='center'>
            <Header icon color='green'>
                <Icon name='check' />
                Successfully registered!

            </Header>
            <p>Please check your emai (including junk) for the Verification email</p>
            {email &&
                <>
                    <p>Didnt receive the email? Click the below button to resend </p>
                    <Button primary onClick={handleConfirmEmailResend}
                        content='Resend email' size='huge' />
                </>
                }
        </Segment>
    )
}
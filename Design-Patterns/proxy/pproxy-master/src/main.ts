import { AuthProxy } from "./AuthProxy.ts";
import { RealAuthService } from "./RealAuthService.ts";

const emailInput = document.querySelector('#username') as HTMLInputElement;
const passwordInput = document.querySelector('#password') as HTMLInputElement;
const loginButton = document.querySelector('#submit-btn') as HTMLButtonElement;

const authProxy = new AuthProxy(new RealAuthService(), false);

loginButton.addEventListener('click', async () => {
    const correo = emailInput.value;
    const contra = passwordInput.value;

    try {
        const success = await authProxy.login(correo, contra);
        if (success) {
            authProxy.setAuthentication(true);
            alert('Usuario loggeado');
        }   
        else {
            alert('Acceso no autorizado');
        }
    } catch (error: any) {
        console.log(error.message);
    }
})

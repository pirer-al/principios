import type { IAuthService } from "./IAuthService";
import { RealAuthService } from './RealAuthService';

export class AuthProxy implements IAuthService {
    private realService : RealAuthService;
    private isAuthenticated: boolean;

    constructor(realService : RealAuthService, initialLoginStatus: boolean) {
        this.realService = realService;
        this.isAuthenticated = initialLoginStatus;
    }

    public async login(email: string, password: string): Promise<boolean> {
        return this.realService.login(email, password);
    }

    public async getProtectedData() : Promise<string> {
        console.log('Interceptando solicitud para validar acceso')
        
        if (!this.isAuthenticated) {
            alert('No autorizado');
            throw new Error('No autorizado');
        }

        return this.realService.getProtectedData();
    }    

    public setAuthentication(status: boolean) {
        this.isAuthenticated = status;
    }
}
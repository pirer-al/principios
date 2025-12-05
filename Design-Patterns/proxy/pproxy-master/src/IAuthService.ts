export interface IAuthService {
    login(email: string, password: string): Promise<boolean>;
    getProtectedData() : Promise <string>;
}

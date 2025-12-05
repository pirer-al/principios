import  type { IAuthService } from "./IAuthService";
import * as data from '../data.json';

export class RealAuthService implements IAuthService {
    async login(email: string, password: string) : Promise <boolean> {

        if (data.email === email && data.contra === password) {
            return true;
        }
        return false;
    }


    async getProtectedData() : Promise<string> {
        return JSON.stringify(data);
    }
}


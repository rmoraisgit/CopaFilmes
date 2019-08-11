import { HttpHeaders } from '@angular/common/http';

export abstract class BaseService {
    protected UrlServiceCopaFilmes: string = 'https://copadosfilmes.azurewebsites.net/api/filmes';
    protected UrlServiceAPI: string = 'https://localhost:44304/api/';

    protected ObterHeaderJson() {
        return {
            headers: new HttpHeaders({
                'Content-Type': 'application/json'
            })
        };
    }
}
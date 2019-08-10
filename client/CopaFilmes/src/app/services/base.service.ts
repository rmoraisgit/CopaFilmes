import { HttpHeaders } from '@angular/common/http';

export abstract class BaseService {
    protected UrlServiceCopaFilmes: string = 'https://copadosfilmes.azurewebsites.net/api/filmes';

    protected ObterHeaderJson() {
        return {
            headers: new HttpHeaders({
                'Content-Type': 'application/json'
            })
        };
    }
}
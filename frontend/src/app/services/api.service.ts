import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { firstValueFrom } from 'rxjs';

@Injectable()
export class ApiService {
  private baseUrl = 'http://localhost:5000/api/';

  constructor(private http: HttpClient) {}

  get<T = any>(route: string, params: any = {}, headers: any = {}) {
    return firstValueFrom<T>(
      this.http.get<T>(this.baseUrl.concat(route), { params, headers })
    );
  }

  post<T = any>(route: string, body: any = {}, headers: any = {}) {
    return firstValueFrom<T>(
      this.http.post<T>(this.baseUrl.concat(route), body, { headers })
    );
  }

  put<T = any>(route: string, body: any = {}, headers: any = {}) {
    return firstValueFrom<T>(
      this.http.put<T>(this.baseUrl.concat(route), body, { headers })
    );
  }

  delete<T = any>(route: string, params: any = {}, headers: any = {}) {
    return firstValueFrom<T>(
      this.http.delete<T>(this.baseUrl.concat(route), { params, headers })
    );
  }

  patch<T = any>(route: string, body: any = {}, headers: any = {}) {
    return firstValueFrom<T>(
      this.http.patch<T>(this.baseUrl.concat(route), body, { headers })
    );
  }
}

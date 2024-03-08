package mk.ukim.finki.lab3_movies.retrofit

import com.google.gson.GsonBuilder
import mk.ukim.finki.lab3_movies.interfaces.api.OmdbApi
import okhttp3.Interceptor
import okhttp3.Request
import okhttp3.Response
import java.io.IOException
import mk.ukim.finki.lab3_movies.BuildConfig
import okhttp3.OkHttpClient
import okhttp3.logging.HttpLoggingInterceptor
import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory

class OmdbApiProvider {
    companion object {
        @Volatile
        private var INSTANCE: OmdbApi? = null

        @JvmStatic
        fun getOmdbApi(): OmdbApi {
            return INSTANCE ?: synchronized(this) {
                val instance = createOmdbApi()
                INSTANCE = instance
                instance
            }
        }

        private fun createOmdbApi(): OmdbApi {
            class QueryParamInterceptor : Interceptor {
                @Throws(IOException::class)
                override fun intercept(chain: Interceptor.Chain): Response {
                    var request: Request = chain.request()
                    val htt = request.url.newBuilder()
                        .addQueryParameter("apikey", BuildConfig.API_KEY)
                        .build()
                    request = request.newBuilder().url(htt).build()
                    return chain.proceed(request)
                }
            }

            val httpLoggingInterceptor = HttpLoggingInterceptor()
            httpLoggingInterceptor.level = HttpLoggingInterceptor.Level.BODY

            val okhttpClient = OkHttpClient.Builder()
                .addInterceptor(QueryParamInterceptor())
                .addInterceptor(httpLoggingInterceptor)
                .build()
            val gson = GsonBuilder()
                .setLenient()
                .create()

            val gsonConverterFactory = GsonConverterFactory.create(gson)

            val retrofit = Retrofit.Builder()
                .baseUrl("https://www.omdbapi.com/")
                .client(okhttpClient)
                .addConverterFactory(gsonConverterFactory)
                .build()
            return retrofit.create(OmdbApi::class.java)
        }
    }

}

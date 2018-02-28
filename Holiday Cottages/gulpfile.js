/// <binding AfterBuild='default' />
var gulp = require('gulp');
var htmlclean = require('gulp-htmlclean');
var uglify = require('gulp-uglify');
var cleanCSS = require('gulp-clean-css');
var sourcemaps = require('gulp-sourcemaps');
var sass = require('gulp-sass');
// folders

var folders = {

    root: "./Assets"

};

gulp.task('js-minify', () => {

    return gulp.src(folders.root + '/JavaScript/**/*')

        .pipe(uglify())

        .pipe(gulp.dest(folders.root + '/Minified/JavaScript/'));

});


gulp.task('compile-sass', function () {
    gulp.src(folders.root + '/sass/**/*.scss')
        .pipe(sass().on('error', sass.logError))
        .pipe(sourcemaps.init())
        .pipe(cleanCSS())
        .pipe(sourcemaps.write())
        .pipe(gulp.dest(folders.root + '/Minified/css/'));
});

gulp.task('default', ['compile-sass', 'js-minify']);

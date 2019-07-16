/// <binding BeforeBuild='sass' AfterBuild='sass' />
'use strict';
const config = require('./client/config.json')

var gulp = require('gulp');
var sass = require('gulp-sass');

sass.compiler = require('node-sass');

gulp.task('sass', function () {
    return gulp.src(config.paths.cssSource)
        .pipe(sass().on('error', sass.logError))
        .pipe(gulp.dest(config.paths.cssDestination));
});